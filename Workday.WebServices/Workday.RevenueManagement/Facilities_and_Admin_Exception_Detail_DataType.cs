using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Facilities_and_Admin_Exception_Detail_DataType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Exception_DetailObjectType facilities_and_Administration_Exception_Detail_ReferenceField;

		private Object_ClassObjectType object_Class_ReferenceField;

		private Facilities_and_Admin_Exception_TypeObjectType facilities_and_Admin_Exception_Type_ReferenceField;

		private decimal rate_OverrideField;

		private bool rate_OverrideFieldSpecified;

		private decimal waive_RateField;

		private bool waive_RateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Exception_DetailObjectType Facilities_and_Administration_Exception_Detail_Reference
		{
			get
			{
				return this.facilities_and_Administration_Exception_Detail_ReferenceField;
			}
			set
			{
				this.facilities_and_Administration_Exception_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Administration_Exception_Detail_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Object_ClassObjectType Object_Class_Reference
		{
			get
			{
				return this.object_Class_ReferenceField;
			}
			set
			{
				this.object_Class_ReferenceField = value;
				this.RaisePropertyChanged("Object_Class_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Facilities_and_Admin_Exception_TypeObjectType Facilities_and_Admin_Exception_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Exception_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Exception_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Exception_Type_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Rate_Override
		{
			get
			{
				return this.rate_OverrideField;
			}
			set
			{
				this.rate_OverrideField = value;
				this.RaisePropertyChanged("Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Rate_OverrideSpecified
		{
			get
			{
				return this.rate_OverrideFieldSpecified;
			}
			set
			{
				this.rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Waive_Rate
		{
			get
			{
				return this.waive_RateField;
			}
			set
			{
				this.waive_RateField = value;
				this.RaisePropertyChanged("Waive_Rate");
			}
		}

		[XmlIgnore]
		public bool Waive_RateSpecified
		{
			get
			{
				return this.waive_RateFieldSpecified;
			}
			set
			{
				this.waive_RateFieldSpecified = value;
				this.RaisePropertyChanged("Waive_RateSpecified");
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
