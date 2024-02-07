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
	public class Procurement_Mass_Close_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType company_or_Company_Hierarchy_ReferenceField;

		private Procurement_Document_TypeObjectType procurement_Document_Type_ReferenceField;

		private DateTime creation_Date_On_or_AfterField;

		private bool creation_Date_On_or_AfterFieldSpecified;

		private DateTime creation_Date_On_or_BeforeField;

		private bool creation_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Creation_Date_On_or_After
		{
			get
			{
				return this.creation_Date_On_or_AfterField;
			}
			set
			{
				this.creation_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Creation_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Creation_Date_On_or_AfterSpecified
		{
			get
			{
				return this.creation_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.creation_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Creation_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Creation_Date_On_or_Before
		{
			get
			{
				return this.creation_Date_On_or_BeforeField;
			}
			set
			{
				this.creation_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Creation_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Creation_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.creation_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.creation_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Creation_Date_On_or_BeforeSpecified");
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
