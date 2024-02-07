using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goal_DataType : INotifyPropertyChanged
	{
		private decimal goal_AmountField;

		private bool goal_AmountFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Goal_Amount
		{
			get
			{
				return this.goal_AmountField;
			}
			set
			{
				this.goal_AmountField = value;
				this.RaisePropertyChanged("Goal_Amount");
			}
		}

		[XmlIgnore]
		public bool Goal_AmountSpecified
		{
			get
			{
				return this.goal_AmountFieldSpecified;
			}
			set
			{
				this.goal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Goal_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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
