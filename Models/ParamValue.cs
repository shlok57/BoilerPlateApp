namespace Shlok.Models
{
	public class ParamValue
	{
		#region private variables

		private int _Id;

		private string _Name;

		private int _Value = -1;

		private bool _IsActive;

		#endregion

		#region public properties

		public int Id
		{
			get { return _Id; }
			set { _Id = value; }
		}

		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public int Value
		{
			get { return _Value; }
			set { _Value = value; }
		}

		public bool IsActive
		{
			get { return _IsActive; }
			set { _IsActive = value; }
		}

		#endregion
	}
}
