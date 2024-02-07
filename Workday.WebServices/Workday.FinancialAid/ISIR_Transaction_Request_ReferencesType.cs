using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ISIR_Transaction_Request_ReferencesType : INotifyPropertyChanged
	{
		private ISIR_TransactionObjectType[] iSIR_Transaction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("ISIR_Transaction_Reference", Order = 0)]
		public ISIR_TransactionObjectType[] ISIR_Transaction_Reference
		{
			get
			{
				return this.iSIR_Transaction_ReferenceField;
			}
			set
			{
				this.iSIR_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Reference");
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
