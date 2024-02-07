using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Costing_Allocations_Response_GroupType : INotifyPropertyChanged
	{
		private bool exclude_Allocation_Detail_DataField;

		private bool exclude_Allocation_Detail_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Exclude_Allocation_Detail_Data
		{
			get
			{
				return this.exclude_Allocation_Detail_DataField;
			}
			set
			{
				this.exclude_Allocation_Detail_DataField = value;
				this.RaisePropertyChanged("Exclude_Allocation_Detail_Data");
			}
		}

		[XmlIgnore]
		public bool Exclude_Allocation_Detail_DataSpecified
		{
			get
			{
				return this.exclude_Allocation_Detail_DataFieldSpecified;
			}
			set
			{
				this.exclude_Allocation_Detail_DataFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Allocation_Detail_DataSpecified");
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
