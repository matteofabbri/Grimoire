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
	public class Funding_Source_Priority_DataType : INotifyPropertyChanged
	{
		private string evaluation_OrderField;

		private string descriptionField;

		private Funding_Source_Priority_Section_DataType[] funding_Source_Priority_Section_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Evaluation_Order
		{
			get
			{
				return this.evaluation_OrderField;
			}
			set
			{
				this.evaluation_OrderField = value;
				this.RaisePropertyChanged("Evaluation_Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Funding_Source_Priority_Section_Data", Order = 2)]
		public Funding_Source_Priority_Section_DataType[] Funding_Source_Priority_Section_Data
		{
			get
			{
				return this.funding_Source_Priority_Section_DataField;
			}
			set
			{
				this.funding_Source_Priority_Section_DataField = value;
				this.RaisePropertyChanged("Funding_Source_Priority_Section_Data");
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
