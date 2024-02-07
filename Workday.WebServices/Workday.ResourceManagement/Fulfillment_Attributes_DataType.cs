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
	public class Fulfillment_Attributes_DataType : INotifyPropertyChanged
	{
		private decimal lead_TimeField;

		private bool lead_TimeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Lead_Time
		{
			get
			{
				return this.lead_TimeField;
			}
			set
			{
				this.lead_TimeField = value;
				this.RaisePropertyChanged("Lead_Time");
			}
		}

		[XmlIgnore]
		public bool Lead_TimeSpecified
		{
			get
			{
				return this.lead_TimeFieldSpecified;
			}
			set
			{
				this.lead_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Lead_TimeSpecified");
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
