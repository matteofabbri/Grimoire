using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Educational_Institution_District_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string educational_Institution_District_NameField;

		private string educational_Institution_District_NCES_IDField;

		private string educational_Institution_District_State_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Educational_Institution_District_Name
		{
			get
			{
				return this.educational_Institution_District_NameField;
			}
			set
			{
				this.educational_Institution_District_NameField = value;
				this.RaisePropertyChanged("Educational_Institution_District_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Educational_Institution_District_NCES_ID
		{
			get
			{
				return this.educational_Institution_District_NCES_IDField;
			}
			set
			{
				this.educational_Institution_District_NCES_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_District_NCES_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Educational_Institution_District_State_ID
		{
			get
			{
				return this.educational_Institution_District_State_IDField;
			}
			set
			{
				this.educational_Institution_District_State_IDField = value;
				this.RaisePropertyChanged("Educational_Institution_District_State_ID");
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
