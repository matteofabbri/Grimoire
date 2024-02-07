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
	public class Award_Schedule_DataType : INotifyPropertyChanged
	{
		private string award_Schedule_Reference_IDField;

		private string award_Schedule_NameField;

		private Award_Posting_Interval_GroupObjectType[] award_Posting_Interval_Group_ReferenceField;

		private Award_Year_DataType[] award_Period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Schedule_Reference_ID
		{
			get
			{
				return this.award_Schedule_Reference_IDField;
			}
			set
			{
				this.award_Schedule_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Schedule_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Schedule_Name
		{
			get
			{
				return this.award_Schedule_NameField;
			}
			set
			{
				this.award_Schedule_NameField = value;
				this.RaisePropertyChanged("Award_Schedule_Name");
			}
		}

		[XmlElement("Award_Posting_Interval_Group_Reference", Order = 2)]
		public Award_Posting_Interval_GroupObjectType[] Award_Posting_Interval_Group_Reference
		{
			get
			{
				return this.award_Posting_Interval_Group_ReferenceField;
			}
			set
			{
				this.award_Posting_Interval_Group_ReferenceField = value;
				this.RaisePropertyChanged("Award_Posting_Interval_Group_Reference");
			}
		}

		[XmlElement("Award_Period_Data", Order = 3)]
		public Award_Year_DataType[] Award_Period_Data
		{
			get
			{
				return this.award_Period_DataField;
			}
			set
			{
				this.award_Period_DataField = value;
				this.RaisePropertyChanged("Award_Period_Data");
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
