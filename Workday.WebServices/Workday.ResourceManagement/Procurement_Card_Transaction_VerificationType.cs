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
	public class Procurement_Card_Transaction_VerificationType : INotifyPropertyChanged
	{
		private Procurement_Card_Transaction_VerificationObjectType procurement_Card_Transaction_Verification_ReferenceField;

		private Procurement_Card_Transaction_Verification_DataType[] procurement_Card_Transaction_Verification_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Procurement_Card_Transaction_VerificationObjectType Procurement_Card_Transaction_Verification_Reference
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_ReferenceField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_Reference");
			}
		}

		[XmlElement("Procurement_Card_Transaction_Verification_Data", Order = 1)]
		public Procurement_Card_Transaction_Verification_DataType[] Procurement_Card_Transaction_Verification_Data
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_DataField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_DataField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_Data");
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
