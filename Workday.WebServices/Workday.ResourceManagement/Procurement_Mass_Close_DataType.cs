using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Procurement_Mass_Close_DataType : INotifyPropertyChanged
	{
		private string procurement_Mass_Close_IDField;

		private OrganizationObjectType company_or_Company_Hierarchy_ReferenceField;

		private Procurement_Document_TypeObjectType procurement_Document_Type_ReferenceField;

		private string procurement_Mass_Close_Request_NameField;

		private string memoField;

		private Procurement_Year_End_Request_Line_DataType[] procurement_Mass_Close_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Procurement_Mass_Close_ID
		{
			get
			{
				return this.procurement_Mass_Close_IDField;
			}
			set
			{
				this.procurement_Mass_Close_IDField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_ID");
			}
		}

		[XmlElement(Order = 1)]
		public OrganizationObjectType Company_or_Company_Hierarchy_Reference
		{
			get
			{
				return this.company_or_Company_Hierarchy_ReferenceField;
			}
			set
			{
				this.company_or_Company_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Company_or_Company_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Procurement_Document_TypeObjectType Procurement_Document_Type_Reference
		{
			get
			{
				return this.procurement_Document_Type_ReferenceField;
			}
			set
			{
				this.procurement_Document_Type_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Document_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Procurement_Mass_Close_Request_Name
		{
			get
			{
				return this.procurement_Mass_Close_Request_NameField;
			}
			set
			{
				this.procurement_Mass_Close_Request_NameField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Request_Name");
			}
		}

		[XmlElement(Order = 4)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Procurement_Mass_Close_Line_Data", Order = 5)]
		public Procurement_Year_End_Request_Line_DataType[] Procurement_Mass_Close_Line_Data
		{
			get
			{
				return this.procurement_Mass_Close_Line_DataField;
			}
			set
			{
				this.procurement_Mass_Close_Line_DataField = value;
				this.RaisePropertyChanged("Procurement_Mass_Close_Line_Data");
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
