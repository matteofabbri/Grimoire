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
	public class Withholding_Tax_Code_Request_ReferencesType : INotifyPropertyChanged
	{
		private Tax_CodeObjectType[] withholding_Tax_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Withholding_Tax_Code_Reference", Order = 0)]
		public Tax_CodeObjectType[] Withholding_Tax_Code_Reference
		{
			get
			{
				return this.withholding_Tax_Code_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Reference");
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
