using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Name_Prefix_DataType : INotifyPropertyChanged
	{
		private Country_Predefined_Person_Name_Component_ValueObjectType title_ReferenceField;

		private string title_DescriptorField;

		private Country_Predefined_Person_Name_Component_ValueObjectType salutation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Title_Reference
		{
			get
			{
				return this.title_ReferenceField;
			}
			set
			{
				this.title_ReferenceField = value;
				this.RaisePropertyChanged("Title_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Title_Descriptor
		{
			get
			{
				return this.title_DescriptorField;
			}
			set
			{
				this.title_DescriptorField = value;
				this.RaisePropertyChanged("Title_Descriptor");
			}
		}

		[XmlElement(Order = 2)]
		public Country_Predefined_Person_Name_Component_ValueObjectType Salutation_Reference
		{
			get
			{
				return this.salutation_ReferenceField;
			}
			set
			{
				this.salutation_ReferenceField = value;
				this.RaisePropertyChanged("Salutation_Reference");
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
