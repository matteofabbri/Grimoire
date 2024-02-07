using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Costing_Allocation_Interval_DataType : INotifyPropertyChanged
	{
		private Costing_Interval_Update_KeyType[] costing_Interval_Update_KeyField;

		private string costing_Override_IDField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Costing_Allocation_Detail_Replacement_DataType[] costing_Allocation_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Costing_Interval_Update_Key", Order = 0)]
		public Costing_Interval_Update_KeyType[] Costing_Interval_Update_Key
		{
			get
			{
				return this.costing_Interval_Update_KeyField;
			}
			set
			{
				this.costing_Interval_Update_KeyField = value;
				this.RaisePropertyChanged("Costing_Interval_Update_Key");
			}
		}

		[XmlElement(Order = 1)]
		public string Costing_Override_ID
		{
			get
			{
				return this.costing_Override_IDField;
			}
			set
			{
				this.costing_Override_IDField = value;
				this.RaisePropertyChanged("Costing_Override_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement("Costing_Allocation_Detail_Data", Order = 4)]
		public Costing_Allocation_Detail_Replacement_DataType[] Costing_Allocation_Detail_Data
		{
			get
			{
				return this.costing_Allocation_Detail_DataField;
			}
			set
			{
				this.costing_Allocation_Detail_DataField = value;
				this.RaisePropertyChanged("Costing_Allocation_Detail_Data");
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
