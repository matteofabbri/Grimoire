using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Local_Person_Name_Detail_DataType : INotifyPropertyChanged
	{
		private string first_NameField;

		private string middle_NameField;

		private string last_NameField;

		private string secondary_Last_NameField;

		private string first_Name_2Field;

		private string middle_Name_2Field;

		private string last_Name_2Field;

		private string secondary_Last_Name_2Field;

		private string local_NameField;

		private string local_ScriptField;

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
		public string First_Name_2
		{
			get
			{
				return this.first_Name_2Field;
			}
			set
			{
				this.first_Name_2Field = value;
				this.RaisePropertyChanged("First_Name_2");
			}
		}

		[XmlElement(Order = 5)]
		public string Middle_Name_2
		{
			get
			{
				return this.middle_Name_2Field;
			}
			set
			{
				this.middle_Name_2Field = value;
				this.RaisePropertyChanged("Middle_Name_2");
			}
		}

		[XmlElement(Order = 6)]
		public string Last_Name_2
		{
			get
			{
				return this.last_Name_2Field;
			}
			set
			{
				this.last_Name_2Field = value;
				this.RaisePropertyChanged("Last_Name_2");
			}
		}

		[XmlElement(Order = 7)]
		public string Secondary_Last_Name_2
		{
			get
			{
				return this.secondary_Last_Name_2Field;
			}
			set
			{
				this.secondary_Last_Name_2Field = value;
				this.RaisePropertyChanged("Secondary_Last_Name_2");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Local_Name
		{
			get
			{
				return this.local_NameField;
			}
			set
			{
				this.local_NameField = value;
				this.RaisePropertyChanged("Local_Name");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Local_Script
		{
			get
			{
				return this.local_ScriptField;
			}
			set
			{
				this.local_ScriptField = value;
				this.RaisePropertyChanged("Local_Script");
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
