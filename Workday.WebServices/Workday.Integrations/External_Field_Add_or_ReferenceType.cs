using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Field_Add_or_ReferenceType : INotifyPropertyChanged
	{
		private External_FieldObjectType class_Report_Field_ReferenceField;

		private string calculated_Field_Class_NameField;

		private string calculated_Field_Reference_IDField;

		private string calculated_Field_NameField;

		private Business_ObjectObjectType business_Object_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public External_FieldObjectType Class_Report_Field_Reference
		{
			get
			{
				return this.class_Report_Field_ReferenceField;
			}
			set
			{
				this.class_Report_Field_ReferenceField = value;
				this.RaisePropertyChanged("Class_Report_Field_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Calculated_Field_Class_Name
		{
			get
			{
				return this.calculated_Field_Class_NameField;
			}
			set
			{
				this.calculated_Field_Class_NameField = value;
				this.RaisePropertyChanged("Calculated_Field_Class_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Calculated_Field_Reference_ID
		{
			get
			{
				return this.calculated_Field_Reference_IDField;
			}
			set
			{
				this.calculated_Field_Reference_IDField = value;
				this.RaisePropertyChanged("Calculated_Field_Reference_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Calculated_Field_Name
		{
			get
			{
				return this.calculated_Field_NameField;
			}
			set
			{
				this.calculated_Field_NameField = value;
				this.RaisePropertyChanged("Calculated_Field_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Business_ObjectObjectType Business_Object_Reference
		{
			get
			{
				return this.business_Object_ReferenceField;
			}
			set
			{
				this.business_Object_ReferenceField = value;
				this.RaisePropertyChanged("Business_Object_Reference");
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
