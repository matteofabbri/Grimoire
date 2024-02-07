using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Stock_Plan_Unit_DataType : INotifyPropertyChanged
	{
		private decimal target_SharesField;

		private bool target_SharesFieldSpecified;

		private Stock_Vesting_ScheduleObjectType stock_Vesting_Schedule_ReferenceField;

		private Grant_Type_Split_Replacement_DataType[] grant_Split_Replacement_DataField;

		private Stock_Plan_Unit_Profile_Replacement_DataType[] stock_Plan_Unit_Profile_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Target_Shares
		{
			get
			{
				return this.target_SharesField;
			}
			set
			{
				this.target_SharesField = value;
				this.RaisePropertyChanged("Target_Shares");
			}
		}

		[XmlIgnore]
		public bool Target_SharesSpecified
		{
			get
			{
				return this.target_SharesFieldSpecified;
			}
			set
			{
				this.target_SharesFieldSpecified = value;
				this.RaisePropertyChanged("Target_SharesSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Stock_Vesting_ScheduleObjectType Stock_Vesting_Schedule_Reference
		{
			get
			{
				return this.stock_Vesting_Schedule_ReferenceField;
			}
			set
			{
				this.stock_Vesting_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Vesting_Schedule_Reference");
			}
		}

		[XmlElement("Grant_Split_Replacement_Data", Order = 2)]
		public Grant_Type_Split_Replacement_DataType[] Grant_Split_Replacement_Data
		{
			get
			{
				return this.grant_Split_Replacement_DataField;
			}
			set
			{
				this.grant_Split_Replacement_DataField = value;
				this.RaisePropertyChanged("Grant_Split_Replacement_Data");
			}
		}

		[XmlElement("Stock_Plan_Unit_Profile_Replacement_Data", Order = 3)]
		public Stock_Plan_Unit_Profile_Replacement_DataType[] Stock_Plan_Unit_Profile_Replacement_Data
		{
			get
			{
				return this.stock_Plan_Unit_Profile_Replacement_DataField;
			}
			set
			{
				this.stock_Plan_Unit_Profile_Replacement_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Unit_Profile_Replacement_Data");
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
