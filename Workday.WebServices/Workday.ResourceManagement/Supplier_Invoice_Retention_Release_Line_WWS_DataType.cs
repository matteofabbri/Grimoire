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
	public class Supplier_Invoice_Retention_Release_Line_WWS_DataType : INotifyPropertyChanged
	{
		private string retention_Release_Line_IDField;

		private Abstract_Retainable_LineObjectType pO_or_Contract_Line_with_Retention_ReferenceField;

		private decimal amount_ReleasedField;

		private bool amount_ReleasedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Retention_Release_Line_ID
		{
			get
			{
				return this.retention_Release_Line_IDField;
			}
			set
			{
				this.retention_Release_Line_IDField = value;
				this.RaisePropertyChanged("Retention_Release_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Retainable_LineObjectType PO_or_Contract_Line_with_Retention_Reference
		{
			get
			{
				return this.pO_or_Contract_Line_with_Retention_ReferenceField;
			}
			set
			{
				this.pO_or_Contract_Line_with_Retention_ReferenceField = value;
				this.RaisePropertyChanged("PO_or_Contract_Line_with_Retention_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount_Released
		{
			get
			{
				return this.amount_ReleasedField;
			}
			set
			{
				this.amount_ReleasedField = value;
				this.RaisePropertyChanged("Amount_Released");
			}
		}

		[XmlIgnore]
		public bool Amount_ReleasedSpecified
		{
			get
			{
				return this.amount_ReleasedFieldSpecified;
			}
			set
			{
				this.amount_ReleasedFieldSpecified = value;
				this.RaisePropertyChanged("Amount_ReleasedSpecified");
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
