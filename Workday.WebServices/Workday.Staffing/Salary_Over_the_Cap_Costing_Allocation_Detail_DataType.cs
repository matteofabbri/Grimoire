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
	public class Salary_Over_the_Cap_Costing_Allocation_Detail_DataType : INotifyPropertyChanged
	{
		private string sOC_OrderField;

		private object[] itemsField;

		private decimal sOC_Distribution_PercentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string SOC_Order
		{
			get
			{
				return this.sOC_OrderField;
			}
			set
			{
				this.sOC_OrderField = value;
				this.RaisePropertyChanged("SOC_Order");
			}
		}

		[XmlElement("SOC_Default_from_Organization_Assignment", typeof(bool), Order = 1), XmlElement("SOC_Override_Worktag_Reference", typeof(Tenanted_Payroll_WorktagObjectType), Order = 1)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement(Order = 2)]
		public decimal SOC_Distribution_Percent
		{
			get
			{
				return this.sOC_Distribution_PercentField;
			}
			set
			{
				this.sOC_Distribution_PercentField = value;
				this.RaisePropertyChanged("SOC_Distribution_Percent");
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
