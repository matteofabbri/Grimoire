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
	public class Corporate_Credit_Card_AccountType : INotifyPropertyChanged
	{
		private Corporate_Credit_Card_AccountObjectType corporate_Credit_Card_Account_ReferenceField;

		private Corporate_Credit_Card_Account_DataType corporate_Credit_Card_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Corporate_Credit_Card_AccountObjectType Corporate_Credit_Card_Account_Reference
		{
			get
			{
				return this.corporate_Credit_Card_Account_ReferenceField;
			}
			set
			{
				this.corporate_Credit_Card_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Corporate_Credit_Card_Account_DataType Corporate_Credit_Card_Account_Data
		{
			get
			{
				return this.corporate_Credit_Card_Account_DataField;
			}
			set
			{
				this.corporate_Credit_Card_Account_DataField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Data");
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
