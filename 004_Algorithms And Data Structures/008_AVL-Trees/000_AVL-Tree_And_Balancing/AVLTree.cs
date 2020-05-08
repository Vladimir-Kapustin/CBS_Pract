﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _000_AVL_Tree_And_Balancing
{
    class AVLTree<T> : IEnumerable<T> where T : IComparable <T>    //Поскольку коллекция параметризированная, то и Итератор лучше применять параметризированный. Потому, что не параметризированный возвращает object. А так возвращается нужный нам тип. см. документацию - yield, Итераторы (ссылки - в браузере - к этому уроку)
    {
        //AVLTreeNode<T> head;  //Вот здесь лучше сделать всё-таки не переменную, а публичное свойство - потому, что в классе AVLTreeNode будет обращение к этой переменной - и её придётся сделать публичной. Но обращение к переменным другого класса напрямую (и соответственно предосавление публичного доступа к ним с помощью модификатора public) считается плохим стилем. В этих случаях принято использовать свойства. Итак правило: если мы собираемся обращаться к переменной в дальнейшем из другого класса - то нужно делать свойство доступа к ней, или авто-свойсво.

        public AVLTreeNode<T> Head
        {
            get;            //чтоб получить можно было везде
            internal set;    //а установить можно было только в этой сборке.
        }

        #region Количество узлов дерева
        public int Count
        {
            get;
            private set;    //обязательно ставим private - чтобы из внешнего кода нельзя было изменить переменную, которая отображает количество элементов в дереве, и чтоб не исказить картину.
        }
        #endregion

        #region Добавление узла: Add & AddTo (Recursion)
        public void Add(T value)
        {
            if (Head == null) //если корня ещё не существует - вносим первый элемент как корень.
            {
                this.Head = new AVLTreeNode<T>(value, null, this);
            }
            else        // если корень существует, то вызываем рекурсивно следующий метод для прохода по дереву в поисках места для элемента с последующим его добавлением.
            {
                AddTo(Head, value); // и сразу запускаем в него head, чтобы от него искать.
            }
            Count++; // добавляем элемент, а значит увеличиваем внутренний счётчик на 1.
        }

        private void AddTo(AVLTreeNode<T> node, T value)
        {
            // Если добавляемый элемент меньше родителя
            if (value.CompareTo(node.Value) < 0)
            {
                //создаём левый узел, если его не было:
                if (node.Left == null)
                {
                    node.Left = new AVLTreeNode<T>(value, node, this); //1.Само значение, 2.Ссылка на родителя - а мы как раз этого родителя передали в этот метод, 3.Дерево: этот класс.
                }
                else
                {   //Вот здесь и пойдёт рекурсия (не надо искать самый левый элемент - это чушь!!!) - в случае, если следующее место будет свободное - он туда и поставит новый элемент, а заодно (раз этот метод вызывается рекурсивно) он тут же проверит меньше добавляемый элемент или больше чем текущий элемент, и соответственно установит новый элемент влево или вправо.
                    AddTo(node.Left, value);//то есть, если левый узел уже существует - то передаём его же уже в следующий вызов метода AddTo.
                }
            }
            else // (Если добавляемый узел больше или равен родителю)
            {
                if (node.Right == null)
                {
                    node.Right = new AVLTreeNode<T>(value, node, this);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
            //node.Balance(); // (можно (и правильно) раскомментировать. Но я оставил закомментированным, т.к. иначе у меня не получается нарисованное в классе Program дерево № 2) :). ) //здесь будет проверка балансировки: мы добавили элемент - следовательно, дерево могло разбалансироваться. Срабатывать будет так: при добавлении элемента тут же проверяется балансировка его родителя. Родитель окажется сбалансированым, т.к. к нему добавили только 1 элемент: даже если у него нет 2-го, разница в высоте поддеревьев будет не больше 1. Если мы рекурсивно зашли далеко в поддерево, после добавления очередного элемента и выхода из рекурсивного метода на предыдущий шаг рекурсии, может оказаться что предыдущий родитель разбалансирован - здесь и срабатывает балансировка. И так по пути вверх до самого корня будут балансироваться все элементы.
        }
        #endregion

        #region Метод Contains (with & without recursion)
        #region Мой способ
        //public bool Contains(T value)
        //{
        //    //тут придётся рекурсивно
        //    return Find(Head, value) != null; //рекурсию - можно, но как известно, с рекурсией возрастает сложность алгоритма. К тому же если искать в большом дереве несуществующий элемент, то, в зависимости от ветвлений (от длины поддеревьев, от цифр и т.д.), программа, заходя далеко в поддеревья, может лишний раз вызывать несколько рекурсий (хотя, может это как раз и правильно, и это будет при любом алгоритме).
        //}

        //public AVLTreeNode<T> Find(AVLTreeNode<T> node, T value) //Find пишем с возвращаемым значением AVLTreeNode<T> - чтобы возвращал нам найденный конкретный экземпляр. Его будем использовать при проверке на равенство null в методе Contains - для возврата true или false. Значение возвращаемого узла в нём использовано не будет. Оно будет использовано в методе Remove.
        //{
        //    AVLTreeNode<T> current = node;  //указатель на вносимый в метод узел (сначала это будет корень, а потом рекурсивно - другие узлы)

        //    while (current != null)
        //    {
        //        if (value.CompareTo(current.Value) < 0) //если нельзя непосредственно со значениями/элементами работать (т.е. нельзя так просто перейти к следующему, а за ним ещё к следующему) - можно использовать рекурсию, можно цикл while, может ещё что-нибудь.
        //        {
        //            current = current.Left;
        //            return Find(current, value);
        //        }
        //        if (value.CompareTo(current.Value) > 0)
        //        {
        //            current = current.Right;
        //            return Find(current, value);
        //        }
        //        else
        //        {
        //            return current;// искомый элемент найден (дальше он возвращается обратно по цепочке вызовов)
        //        }
        //    }
        //    return current; // если ввели несуществующее значение - то по переходам метод (хоть и с лишними рекурсиями) рано или поздно упрётся в конец какого-либо поддерева и в null, тогда эта строка для того чтобы из последней рекурсии вернуть null - дальше по цепочке вызовов это значение вернётся в самый первый вызов и в метод Contains, который, логично, вернёт false.
        //}
        #endregion

        #region Способ из примера
        //гораздо проще и не требует никаких рекурсий:
        public bool Contains(T value)
        {
            return Find(value) != null;
        }
        // буду записывать логику: как автор соображал: чтобы и я так соображал. - А 2 часа подряд работать - действительно "вставляет".
        private AVLTreeNode<T> Find(T value)    //не забываем про private - нам не нужно, чтобы этот метод вызывался где-то кроме этого класса - только здесь. прячем его.
        {
            AVLTreeNode<T> current = Head; //когда проходимся по какому-нибудь списку/дереву часто можно использовать указатель. Ставим указатель на корень дерева.

            while (current != null) //делаем цикл. будем проходиться по дереву по каждому элементу (в нужном направлении) до тех пор пока указатель не укажет на несуществующий элемент, т.е. до конца какой-то из ветвей.
            {
                int result = current.CompareTo(value);    //Вводим как бы переменную-якорь, которая будет сравнивать искомое значение с указателем. Если это значение больше - перемещаеся вправо, иначе - влево, а иначе - стоп цикл и возвращаем текущий элемент(на котором находится указатель).
                // первоначально я написал int result = value.CompareTo(current.Value); - это тоже правильно, но: вызывается системный CompareTo - того типа, на элементе которого он вызывается. А наш пользовательский CompareTo, который прописан в классе AVLTreeNode<T> - остаётся незадействованным и ненужным. А нас это не устраивает: не зря ж мы соответствующий метод писали.
                if (result > 0) // если указатель больше искомого значения, то
                {
                    current = current.Left; // перемещаем указатель влево
                }
                else if (result < 0) // если указатель меньше элемента, то
                {
                    current = current.Right; // перемещаем указатель вправо.
                }
                else // иначе - т.е. если указатель равен элементу - останавливаем цикл (а после цикла возвращается элемент, значение которого равно искомому значению - элемент, на котором остановился указатель, при остановке цикла)
                {
                    break;
                }
            }
            return current; //возвращается элемент, значение которого равно искомому значению - элемент, на котором остановился указатель, при остановке цикла.
        }

        #endregion

        #endregion

        #region Удаление узла: Remove
        public bool Remove(T value)
        {
            // можно воспользоваться методом Find.
            AVLTreeNode<T> current = Find(value); //вместо прохождения по всему дереву в этом методе - используем уже существующий метод Find, который делает то же самое.
            Count--; // уменьшаем количество узлов в дереве на 1 из-за удаления.

            AVLTreeNode<T> treeToBalance = current.Parent;  //Добавляем указатель для балансировки родительского элемента удаляемого элемента, т.к. родительски элемент может разбалансироваться после удаления его потомка. Относительно этого указателя позже будем проверять и проводиь балансировку.

            if (current == null)  //если искомый узел не существует возвращаем false - и дальше вообще не смотрим - сразу выйти из метода и не делать длинной конструкции. Так короче, чем если проверять if (current != null) и внутрь этой конструкции ставить весь остальной код. Если false - то код дальше просто не пойдёт.
            {
                return false;
            }

            // 1-й вариант: если удаляемый элемент не имеет правого элемента - то сместить на место удаляемого элемента его левого потомка.
            if (current.Right == null) // если у него нет правого потомка
            {
                if (current.Parent == null)  // если удаляемый узел является корнем
                {
                    Head = current.Left;    // то левого потомка удаляемого элемента делаем корнем. А если при этом и левый равен null - получается нет ни правого, ни левого. Т.е. мы удаляем единственный элемент в дереве - корень. И в head автоматически записывается null.
                    if (current.Left != null) // и если у него есть левый потомок
                    {
                        Head.Parent = null; // то, поскольку левый теперь становится корнем, удаляем в нём ссылку на родителя.
                    }
                }
                else // если удаляемый узел не является корнем
                {
                    int result = current.Parent.CompareTo(current.Value);   // здесь надо проверить: удаляемый элемент находился справа или слева от своего родителя. Для этого вводим буферную переменную, которая покажет: справа элемент или слева. // здесь можно было бы поставить в скобках и просто value - т.к. это будет значение именно удаляемого элемента. Но (и в примере так и указано) можно использовать и current.Value - что б уже как говориться "точно" указало на то что нужно.

                    if (result > 0) //родитель больше, а элемент - меньше (значит слева)
                    {
                        current.Parent.Left = current.Left;     // родитель удаляемого элемента ссылается (по левой ссылке) на левого потомка удаляемого узла.
                        if (current.Left != null)
                        {
                            current.Left.Parent = current.Parent;    // А вот здесь - интересный момент: в примере урока в классе AVLTreeNode в свойствах элемента Left и Right было прописано, что если они не равны null, то в левом(или правом) потомке устанавливалась родительская ссылка на текущий элемент.  - Поэтому в примерах ссылка на новый родительский элемент устанавливалась автоматически, и текущей строки там нет. Здесь же я немного своим путём пошёл (не таким удобным:)). В этой строке - левый потомок теперь ссылается на родителя удаляемого элемента.
                        }
                    }
                    else if (result < 0)   // если родитель меньше, значит элемент справа.     //лучше ставить else if, а не просто if - чтобы во второй if лишний раз не зашло.
                    {
                        current.Parent.Right = current.Left;     // родитель удаляемого элемента ссылается (по правой ссылке) на левого потомка удаляемого узла.
                        if (current.Left != null)
                        {
                            current.Left.Parent = current.Parent;    // левый потомок теперь ссылается на родителя удаляемого элемента
                        }
                    }
                }
            }
            //2-й вариант: если удаляемый элемент имеет правого потомка, который не имеет левого потомка: тогда сделать правого потомка потомком родительского узла.
            else if (current.Right.Left == null)   //проверка 2-го условия 2-го варианта    
            {
                if (current.Parent == null)    // если удаляемый узел является корнем
                {
                    Head = current.Right;
                    current.Right.Left = current.Left;
                    if (current.Left != null) // проверить существует ли левый потомок удаляемого узла, иначе будет NullReferenceException
                    {
                        current.Left.Parent = current.Right; //и дать ему ссылку на нового родителя.
                    }
                }
                else //если удаляемый корнем не является.
                {
                    int result = current.Parent.CompareTo(current.Value); //буферная переменная: отображает - слева текущий элемент или справа от родителя?

                    if (result > 0)
                    {
                        current.Parent.Left = current.Right;
                        current.Right.Left = current.Left;  //(повторяющийся код)вынесена вверх в примере урока
                        current.Right.Parent = current.Parent; //(повторяющийся код)делается автоматически в примере урока
                        if (current.Left != null) //- да действительно, лучше подобную операцию перенести в определение класса... - Это то, то в примере урока прописано в классе AVLTreeNode.
                        {
                            current.Left.Parent = current.Right; //если использовать определение класса AVLTreeNode как в примере урока, то эту строку необязательно писать - эта операция произойдёт автоматически.
                        }

                    }
                    else if (result < 0)
                    {
                        current.Parent.Right = current.Right;
                        current.Right.Left = current.Left;  //(повторяющийся код)вынесена вверх в примере урока
                        current.Right.Parent = current.Parent; //(повторяющийся код)делается автоматически в примере урока
                        if (current.Left != null) //(повторяющийся код)делается автоматически в примере урока
                        {
                            current.Left.Parent = current.Right; //(повторяющийся код)делается автоматически в примере урока
                        }
                    }
                }
            }
            // 3-й вариант: если у правого потомка удаляемого элемента есть левый потомок: поместить крайнего левого потомка на место удаляемого узла (сделать родителя удаляемого узла родителем этого крайнего левого потомка)
            else
            {
                AVLTreeNode<T> leftMost = current.Right.Left;   //добавляем ещё один указатель: на этот самый левый потомок правого потомка.

                while (leftMost.Left != null)   //циклом перемещаем этот указатель на самого последнего из левых потомков.
                {
                    leftMost = leftMost.Left; 
                }

                leftMost.Parent.Left = leftMost.Right;      // Там, где убрали узел leftmost - меняем связи соседствовавших с ним элементов.
                leftMost.Right.Parent = leftMost.Parent;    // Поскольку эти 4 строки будут независимо от того, становится ли leftMost корнем дерева или нет, то выносим их за пределы if.
                leftMost.Left = current.Left;   //левый
                leftMost.Right = current.Right; //правый

                if (current.Parent == null)
                {
                    Head = leftMost;        //смещаем элементы в соответствии с правилом и устанавливаем новые связи.
                    current.Right.Parent = leftMost;                        // (повторяющийся код - можно вынести вверх. но не буду, оставлю, чтоб понаблюдать можно было)
                    if (current.Left != null)                               // (повторяющийся код - можно вынести вверх)
                    {
                        current.Left.Parent = leftMost;
                    }
                    leftMost.Parent = null; //убираем из leftMost ссылку на его бывшего родителя, т.к. leftMost теперь корень.
                }
                else
                {   //проверка нахождения leftMost слева или справа от его родителя.
                    int result = current.Parent.CompareTo(current.Value);

                    if (result > 0)
                    {
                        current.Parent.Left = leftMost;
                    }
                    else if (result < 0)
                    {
                        current.Parent.Right = leftMost;
                    }

                    leftMost.Parent = current.Parent;   //родитель
                    current.Right.Parent = leftMost;   //родитель правого   // (повторяющийся код - можно вынести вверх)
                    if (current.Left != null)                               // (повторяющийся код - можно вынести вверх)
                    {
                        current.Left.Parent = leftMost; //родитель левого
                    }
                }
            }
            treeToBalance.Balance();    //баласировка дерева.
            return true;
        }

        #endregion

        #region Метод Clear
        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        #endregion

        #region Итераторы
        public IEnumerator<T> InOrderTraversal()    //создаём проход по дереву в симметричном порядке.
        {
            // проверяем не пустое ли дерево:
            if (Head != null)
            {
                //создаём стек - как буфер чтобы в правильной последовательности извлекать из него элементы и выводить на экран:
                Stack<AVLTreeNode<T>> stack = new Stack<AVLTreeNode<T>>(); // закрываем его типом узла, а не значением из узла - т.к. мы будем извлекать узлы, а не значения.

                //создаём указатель, которым будем перемещаться по дереву и выводить с помощью него ЗНАЧЕНИЯ:
                AVLTreeNode<T> current = Head; //и ставим его на корневой элемент.

                // создаём "переключатель", который будет говорить - можно ли перемещаться по дереву влево или нет:
                bool moveLeftNext = true; // и устанавливаем его в true чтобы с первого же раза можно было переместиться в левое крыло

                //Помещаем первым элементом в стэк - корень дерева (это значение не будет выведено на экран - оно используется как условие работы цикла (пока стэк не пустой - цикл будет работать), и будет извлечено из стэка в конце алгоритма - не для вывода на экран, а для прекращения работы цикла.)
                stack.Push(current);

                //Начинаем цикл с перемещениями по дереву и выводом элементов:
                while (stack.Count > 0)//пока стэк не пустой (как говорилось раньше)
                {
                    //если перемещаться можно влево:
                    if (moveLeftNext)
                    {
                        while (current.Left != null) //пока левый элемент есть,
                        {
                            stack.Push(current); //то текущий помещаем в стэк (порядок будет как раз какой нужно, когда будем извлекать)
                            current = current.Left; //и ставим указатель на следующий левый (пока левые элементы не прекратятся)
                        }
                    }
                    // если достигнут самый левый элемент - выводим его. ИЛИ: если влево идти было нельзя, указатель у нас поставился на родительский элемент - и выводим его:
                    yield return current.Value; // выводим значение.

                    //когда foreach в следующий раз делает итерацию он заходит сюда и продолжает с этого места

                    // последний левый вывели - теперь проверяем, есть ли правый:
                    if (current.Right!=null)
                    {
                        current = current.Right; // если есть - то ставим на него указатель
                        // текущий элемент пока в стэк не помещаем - он будет помещён позже, если у него будут потомки. Если потомков не будет - он будет выведен на экран.

                        // ставим переключатель moveLeftNext в true - чтобы можно было проверять теперь левое поддерево текущего элемента:
                        moveLeftNext = true;
                    }
                    else // если правого нет,
                    {
                        current = stack.Pop(); // то извлекаем из стэка верхний элемент - это как раз будет родительский элемент текущего элемента - и ставим на него указатель.

                        moveLeftNext = false; // теперь уже идём вправо (проверяем если оно есть), а влево нельзя: мы оттуда уже всё вывели.
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()   // 1) обязаны реализовать, т.к. коллекция реализует IEnumerable<T> // вызывается 2-м после нетипизированного GetEnumerator(), я так понимаю
        {
            return InOrderTraversal();
        }

        IEnumerator IEnumerable.GetEnumerator() // 2) обязаны реализовать, т.к. IEnumerable<T> реализует в свою очередь IEnumerable. // вызывается 1-м в foreach, я так понимаю
        {
            return GetEnumerator();
        }


        #endregion
    }
}
