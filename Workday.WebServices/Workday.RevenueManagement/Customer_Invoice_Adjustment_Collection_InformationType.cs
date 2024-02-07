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
	public class Customer_Invoice_Adjustment_Collection_InformationType : INotifyPropertyChanged
	{
		private DateTime followup_DateField;

		private bool followup_DateFieldSpecified;

		private Note_WWS_DataType[] note_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Followup_Date
		{
			get
			{
				return this.followup_DateField;
			}
			set
			{
				this.followup_DateField = value;
				this.RaisePropertyChanged("Followup_Date");
			}
		}

		[XmlIgnore]
		public bool Followup_DateSpecified
		{
			get
			{
				return this.followup_DateFieldSpecified;
			}
			set
			{
				this.followup_DateFieldSpecified = value;
				this.RaisePropertyChanged("Followup_DateSpecified");
			}
		}

		[XmlElement("Note_Data", Order = 1)]
		public Note_WWS_DataType[] Note_Data
		{
			get
			{
				return this.note_DataField;
			}
			set
			{
				this.note_DataField = value;
				this.RaisePropertyChanged("Note_Data");
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
