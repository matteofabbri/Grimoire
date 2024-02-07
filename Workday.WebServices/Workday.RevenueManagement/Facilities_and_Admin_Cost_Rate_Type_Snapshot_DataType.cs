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
	public class Facilities_and_Admin_Cost_Rate_Type_Snapshot_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType facilities_and_Admin_Cost_Rate_Type_Snapshot_ReferenceField;

		private Facilities_and_Admin_Cost_Rate_Type_TypeObjectType facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;

		private DateTime snapshot_Effective_DateField;

		private decimal percentField;

		private bool percentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Facilities_and_Admin_Cost_Rate_Type_Snapshot_Reference
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Snapshot_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Snapshot_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Snapshot_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Facilities_and_Admin_Cost_Rate_Type_TypeObjectType Facilities_and_Admin_Cost_Rate_Type_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Snapshot_Effective_Date
		{
			get
			{
				return this.snapshot_Effective_DateField;
			}
			set
			{
				this.snapshot_Effective_DateField = value;
				this.RaisePropertyChanged("Snapshot_Effective_Date");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
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
