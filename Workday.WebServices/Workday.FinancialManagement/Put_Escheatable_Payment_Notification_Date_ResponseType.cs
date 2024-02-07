using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Escheatable_Payment_Notification_Date_ResponseType : INotifyPropertyChanged
	{
		private PaymentObjectType escheatable_Payment_ReferenceField;

		private Escheatable_Payment_DataType[] escheatable_Payment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PaymentObjectType Escheatable_Payment_Reference
		{
			get
			{
				return this.escheatable_Payment_ReferenceField;
			}
			set
			{
				this.escheatable_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Escheatable_Payment_Reference");
			}
		}

		[XmlElement("Escheatable_Payment_Data", Order = 1)]
		public Escheatable_Payment_DataType[] Escheatable_Payment_Data
		{
			get
			{
				return this.escheatable_Payment_DataField;
			}
			set
			{
				this.escheatable_Payment_DataField = value;
				this.RaisePropertyChanged("Escheatable_Payment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
