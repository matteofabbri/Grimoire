using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Local_Name_DataType : INotifyPropertyChanged
	{
		private string first_NameField;

		private string middle_NameField;

		private Local_Last_Name_DataType[] last_NameField;

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

		[XmlElement("Last_Name", Order = 2)]
		public Local_Last_Name_DataType[] Last_Name
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
