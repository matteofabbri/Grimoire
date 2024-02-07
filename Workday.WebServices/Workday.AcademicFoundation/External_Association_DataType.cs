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
	public class External_Association_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string external_Association_NameField;

		private External_Association_TypeObjectType external_Association_Type_ReferenceField;

		private External_Association_StatusObjectType external_Association_Status_ReferenceField;

		private Educational_DesignationObjectType[] designation_ReferenceField;

		private Academic_ContactObjectType[] academic_Contact_ReferenceField;

		private Contact_Information_DataType[] contact_Information_DataField;

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
		public string External_Association_Name
		{
			get
			{
				return this.external_Association_NameField;
			}
			set
			{
				this.external_Association_NameField = value;
				this.RaisePropertyChanged("External_Association_Name");
			}
		}

		[XmlElement(Order = 2)]
		public External_Association_TypeObjectType External_Association_Type_Reference
		{
			get
			{
				return this.external_Association_Type_ReferenceField;
			}
			set
			{
				this.external_Association_Type_ReferenceField = value;
				this.RaisePropertyChanged("External_Association_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public External_Association_StatusObjectType External_Association_Status_Reference
		{
			get
			{
				return this.external_Association_Status_ReferenceField;
			}
			set
			{
				this.external_Association_Status_ReferenceField = value;
				this.RaisePropertyChanged("External_Association_Status_Reference");
			}
		}

		[XmlElement("Designation_Reference", Order = 4)]
		public Educational_DesignationObjectType[] Designation_Reference
		{
			get
			{
				return this.designation_ReferenceField;
			}
			set
			{
				this.designation_ReferenceField = value;
				this.RaisePropertyChanged("Designation_Reference");
			}
		}

		[XmlElement("Academic_Contact_Reference", Order = 5)]
		public Academic_ContactObjectType[] Academic_Contact_Reference
		{
			get
			{
				return this.academic_Contact_ReferenceField;
			}
			set
			{
				this.academic_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Contact_Reference");
			}
		}

		[XmlElement("Contact_Information_Data", Order = 6)]
		public Contact_Information_DataType[] Contact_Information_Data
		{
			get
			{
				return this.contact_Information_DataField;
			}
			set
			{
				this.contact_Information_DataField = value;
				this.RaisePropertyChanged("Contact_Information_Data");
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
