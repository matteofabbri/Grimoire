using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Test_Reference_DataType : INotifyPropertyChanged
	{
		private Background_Check_Package_TestObjectType background_Check_Package_Test_ReferenceField;

		private Background_Check_StatusObjectType status_ReferenceField;

		private string test_NameField;

		private string test_DescriptionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Check_Package_TestObjectType Background_Check_Package_Test_Reference
		{
			get
			{
				return this.background_Check_Package_Test_ReferenceField;
			}
			set
			{
				this.background_Check_Package_Test_ReferenceField = value;
				this.RaisePropertyChanged("Background_Check_Package_Test_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Background_Check_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Test_Name
		{
			get
			{
				return this.test_NameField;
			}
			set
			{
				this.test_NameField = value;
				this.RaisePropertyChanged("Test_Name");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Test_Description
		{
			get
			{
				return this.test_DescriptionField;
			}
			set
			{
				this.test_DescriptionField = value;
				this.RaisePropertyChanged("Test_Description");
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
