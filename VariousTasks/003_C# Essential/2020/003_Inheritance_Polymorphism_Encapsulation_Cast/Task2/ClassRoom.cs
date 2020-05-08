
namespace Task2
{
	class ClassRoom
	{
		Pupil[] pupils = new Pupil[4];

		public ClassRoom(Pupil pupil1, Pupil pupil2) 
			: this (pupil1, pupil2, new BadPupil()) {}

		public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
		{
			pupils[0] = pupil1;
			pupils[1] = pupil2;
			pupils[2] = pupil3;
			pupils[3] = new GoodPupil();
		}

		public void Study()
		{
			for (int i = 0; i < pupils.Length; i++)
			{
				pupils[i].Study();
			}
		}

		public void Write()
		{
			for (int i = 0; i < pupils.Length; i++)
			{
				pupils[i].Write();
			}
		}

		public void Read()
		{
			for (int i = 0; i < pupils.Length; i++)
			{
				pupils[i].Read();
			}
		}

		public void Relax()
		{
			for (int i = 0; i < pupils.Length; i++)
			{
				pupils[i].Relax();
			}
		}

	}
}
