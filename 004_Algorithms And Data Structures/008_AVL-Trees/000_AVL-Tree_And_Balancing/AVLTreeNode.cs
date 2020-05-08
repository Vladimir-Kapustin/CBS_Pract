using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_AVL_Tree_And_Balancing
{
    class AVLTreeNode<T> : IComparable<T> where T : IComparable<T>
    {
        AVLTree <T> _tree;

        AVLTreeNode<T> _left;
        AVLTreeNode<T> _right;

        public AVLTreeNode(T value, AVLTreeNode<T> parent, AVLTree<T> tree) // последний параметр будет использован только в методе Balance.
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        #region Свойства
        public T Value
        {
            get;
            set;
        }

        public AVLTreeNode<T> Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
            }
        }

        public AVLTreeNode<T> Right
        {
            get
            {
                return _right;
            }
            set
            {
                _right = value;
            }
        }

        public AVLTreeNode<T> Parent
        {
            get;
            set;
        }
        #endregion

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        #region Балансировка
        public void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right.BalanceFactor < 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    LeftRotation();
                }
            }

            if (State == TreeState.LeftHeavy)
            {
                if (Left.BalanceFactor > 0)
                {
                    LeftRightRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }

        public int MaxChildHeight(AVLTreeNode<T> node)
        {
            if (node!=null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }
            return 0;
        }

        public int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
            
        }

        public int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        public TreeState State
        {
            get
            {
                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }
                
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }
                return TreeState.Balanced;
            }
        }
        
        public enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy
        }

        public int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        #region LeftRotation
        public void LeftRotation()
        {
            AVLTreeNode<T> newRoot = Right;
            ReplaceRoot(newRoot);

            Right = newRoot.Left;
            if (newRoot.Left != null) //этого блока кода не было в примере. У меня есть - я немного усложнил (не писал в свойствах Left и Right автоматическую установку ссылки на родителя)
            {
                newRoot.Left.Parent = this; 
            }
            newRoot.Left = this;
        }
        #endregion

        #region RightRotation
        public void RightRotation ()
        {
            AVLTreeNode<T> newRoot = Left;
            ReplaceRoot(newRoot);

            Left = newRoot.Right;
            if (newRoot.Right != null)    //этого блока кода не было в примере. У меня есть - я немного усложнил (не писал в свойствах Left и Right автоматическую установку ссылки на родителя)
            {
                newRoot.Right.Parent = this; 

            }
            newRoot.Right = this;
        }
        #endregion

        #region RightLeftRotation
        public void RightLeftRotation()
        {
            Right.RightRotation();
            LeftRotation();
        }
        #endregion

        #region LeftRightRotation
        public void LeftRightRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }
        #endregion

        #region ReplaceRoot
        public void ReplaceRoot(AVLTreeNode<T> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                
                if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }
            }
            else
            {
                _tree.Head = newRoot;
            }

            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }
        #endregion

        #endregion
    }
}
