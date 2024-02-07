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
	public class Procurement_Card_Transaction_Verification_Request_ReferencesType : INotifyPropertyChanged
	{
		private Procurement_Card_Transaction_VerificationObjectType[] procurement_Card_Transaction_Verification_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Procurement_Card_Transaction_Verification_Reference", Order = 0)]
		public Procurement_Card_Transaction_VerificationObjectType[] Procurement_Card_Transaction_Verification_Reference
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
