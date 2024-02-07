using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Name_DataType : INotifyPropertyChanged
	{
		private string first_NameField;

		private string middle_NameField;

		private string last_NameField;

		private string secondary_Last_NameField;

		private Candidate_Local_Person_Name_DataType local_Person_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string First_Name
		{
			get
			{
				return this.first_NameField;
			}
			set
			{
				this.first_NameField = value;
				this.RaisePropertyChanged("First_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Middle_Name
		{
			get
			{
				return this.middle_NameField;
			}
			set
			{
				this.middle_NameField = value;
				this.RaisePropertyChanged("Middle_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Last_Name
		{
			get
			{
				return this.last_NameField;
			}
			set
			{
				this.last_NameField = value;
				this.RaisePropertyChanged("Last_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Secondary_Last_Name
		{
			get
			{
				return this.secondary_Last_NameField;
			}
			set
			{
				this.secondary_Last_NameField = value;
				this.RaisePropertyChanged("Secondary_Last_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Candidate_Local_Person_Name_DataType Local_Person_Name
		{
			get
			{
				return this.local_Person_NameField;
			}
			set
			{
				this.local_Person_NameField = value;
				this.RaisePropertyChanged("Local_Person_Name");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
