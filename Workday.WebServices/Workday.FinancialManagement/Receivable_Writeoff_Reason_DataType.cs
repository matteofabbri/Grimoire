using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Receivable_Writeoff_Reason_DataType : INotifyPropertyChanged
	{
		private string receivable_Writeoff_Category_IDField;

		private string receivable_Writeoff_Category_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Receivable_Writeoff_Category_ID
		{
			get
			{
				return this.receivable_Writeoff_Category_IDField;
			}
			set
			{
				this.receivable_Writeoff_Category_IDField = value;
				this.RaisePropertyChanged("Receivable_Writeoff_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Receivable_Writeoff_Category_Name
		{
			get
			{
				return this.receivable_Writeoff_Category_NameField;
			}
			set
			{
				this.receivable_Writeoff_Category_NameField = value;
				this.RaisePropertyChanged("Receivable_Writeoff_Category_Name");
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
