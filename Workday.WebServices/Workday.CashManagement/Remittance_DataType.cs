using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Remittance_DataType : INotifyPropertyChanged
	{
		private Unstructured_Remittance_DataType[] unstructured_Remittance_DataField;

		private Document_Remittance_DataType[] document_Remittance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Unstructured_Remittance_Data", Order = 0)]
		public Unstructured_Remittance_DataType[] Unstructured_Remittance_Data
		{
			get
			{
				return this.unstructured_Remittance_DataField;
			}
			set
			{
				this.unstructured_Remittance_DataField = value;
				this.RaisePropertyChanged("Unstructured_Remittance_Data");
			}
		}

		[XmlElement("Document_Remittance_Data", Order = 1)]
		public Document_Remittance_DataType[] Document_Remittance_Data
		{
			get
			{
				return this.document_Remittance_DataField;
			}
			set
			{
				this.document_Remittance_DataField = value;
				this.RaisePropertyChanged("Document_Remittance_Data");
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
