using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Stock_Plan_Assignment_Container_DataType : INotifyPropertyChanged
	{
		private Proposed_Stock_Plan_Assignment_DataType[] stock_Plan_Sub_DataField;

		private bool replaceField;

		private bool replaceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Stock_Plan_Sub_Data", Order = 0)]
		public Proposed_Stock_Plan_Assignment_DataType[] Stock_Plan_Sub_Data
		{
			get
			{
				return this.stock_Plan_Sub_DataField;
			}
			set
			{
				this.stock_Plan_Sub_DataField = value;
				this.RaisePropertyChanged("Stock_Plan_Sub_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace
		{
			get
			{
				return this.replaceField;
			}
			set
			{
				this.replaceField = value;
				this.RaisePropertyChanged("Replace");
			}
		}

		[XmlIgnore]
		public bool ReplaceSpecified
		{
			get
			{
				return this.replaceFieldSpecified;
			}
			set
			{
				this.replaceFieldSpecified = value;
				this.RaisePropertyChanged("ReplaceSpecified");
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
