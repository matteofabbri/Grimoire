using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Funding_Source_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] owning_Company_and_Other_Allowed_Companies_ReferenceField;

		private string funding_Source_NameField;

		private Spend_RestrictionObjectType[] spend_Restriction_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private DateTime active_As_of_DateField;

		private bool active_As_of_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Owning_Company_and_Other_Allowed_Companies_Reference", Order = 0)]
		public OrganizationObjectType[] Owning_Company_and_Other_Allowed_Companies_Reference
		{
			get
			{
				return this.owning_Company_and_Other_Allowed_Companies_ReferenceField;
			}
			set
			{
				this.owning_Company_and_Other_Allowed_Companies_ReferenceField = value;
				this.RaisePropertyChanged("Owning_Company_and_Other_Allowed_Companies_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Funding_Source_Name
		{
			get
			{
				return this.funding_Source_NameField;
			}
			set
			{
				this.funding_Source_NameField = value;
				this.RaisePropertyChanged("Funding_Source_Name");
			}
		}

		[XmlElement("Spend_Restriction_Reference", Order = 2)]
		public Spend_RestrictionObjectType[] Spend_Restriction_Reference
		{
			get
			{
				return this.spend_Restriction_ReferenceField;
			}
			set
			{
				this.spend_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Active_As_of_Date
		{
			get
			{
				return this.active_As_of_DateField;
			}
			set
			{
				this.active_As_of_DateField = value;
				this.RaisePropertyChanged("Active_As_of_Date");
			}
		}

		[XmlIgnore]
		public bool Active_As_of_DateSpecified
		{
			get
			{
				return this.active_As_of_DateFieldSpecified;
			}
			set
			{
				this.active_As_of_DateFieldSpecified = value;
				this.RaisePropertyChanged("Active_As_of_DateSpecified");
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
