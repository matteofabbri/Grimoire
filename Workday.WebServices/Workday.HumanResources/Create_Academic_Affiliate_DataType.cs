using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Create_Academic_Affiliate_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Person_Name_DataType person_Name_DataField;

		private Contact_Information_DataType contact_Information_DataField;

		private Generic_Personal_Information_DataType personal_Information_DataField;

		private Person_Identification_DataType person_Identification_DataField;

		private Location_ContextObjectType[] location_Contexts_ReferenceField;

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
		public Person_Name_DataType Person_Name_Data
		{
			get
			{
				return this.person_Name_DataField;
			}
			set
			{
				this.person_Name_DataField = value;
				this.RaisePropertyChanged("Person_Name_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Contact_Information_DataType Contact_Information_Data
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

		[XmlElement(Order = 3)]
		public Generic_Personal_Information_DataType Personal_Information_Data
		{
			get
			{
				return this.personal_Information_DataField;
			}
			set
			{
				this.personal_Information_DataField = value;
				this.RaisePropertyChanged("Personal_Information_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Person_Identification_DataType Person_Identification_Data
		{
			get
			{
				return this.person_Identification_DataField;
			}
			set
			{
				this.person_Identification_DataField = value;
				this.RaisePropertyChanged("Person_Identification_Data");
			}
		}

		[XmlElement("Location_Contexts_Reference", Order = 5)]
		public Location_ContextObjectType[] Location_Contexts_Reference
		{
			get
			{
				return this.location_Contexts_ReferenceField;
			}
			set
			{
				this.location_Contexts_ReferenceField = value;
				this.RaisePropertyChanged("Location_Contexts_Reference");
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
