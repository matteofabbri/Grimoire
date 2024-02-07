using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_Purchase_Line_DataType : INotifyPropertyChanged
	{
		private Donor_ContributionObjectType donor_Contribution_ReferenceField;

		private bool override_Default_Unit_PriceField;

		private bool override_Default_Unit_PriceFieldSpecified;

		private DateTime purchase_DateField;

		private bool purchase_DateFieldSpecified;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Donor_ContributionObjectType Donor_Contribution_Reference
		{
			get
			{
				return this.donor_Contribution_ReferenceField;
			}
			set
			{
				this.donor_Contribution_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Contribution_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Override_Default_Unit_Price
		{
			get
			{
				return this.override_Default_Unit_PriceField;
			}
			set
			{
				this.override_Default_Unit_PriceField = value;
				this.RaisePropertyChanged("Override_Default_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Override_Default_Unit_PriceSpecified
		{
			get
			{
				return this.override_Default_Unit_PriceFieldSpecified;
			}
			set
			{
				this.override_Default_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Override_Default_Unit_PriceSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Purchase_Date
		{
			get
			{
				return this.purchase_DateField;
			}
			set
			{
				this.purchase_DateField = value;
				this.RaisePropertyChanged("Purchase_Date");
			}
		}

		[XmlIgnore]
		public bool Purchase_DateSpecified
		{
			get
			{
				return this.purchase_DateFieldSpecified;
			}
			set
			{
				this.purchase_DateFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Unit_Price
		{
			get
			{
				return this.unit_PriceField;
			}
			set
			{
				this.unit_PriceField = value;
				this.RaisePropertyChanged("Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Unit_PriceSpecified
		{
			get
			{
				return this.unit_PriceFieldSpecified;
			}
			set
			{
				this.unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Unit_PriceSpecified");
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
