using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Sub_Process_ParametersType : INotifyPropertyChanged
	{
		private bool itemField;

		private ItemChoiceType itemElementNameField;

		private Business_Process_Comment_DataType business_Process_Comment_DataField;

		private Business_Process_Attachment_DataType[] business_Process_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Auto_Complete", typeof(bool), Order = 0), XmlElement("Skip", typeof(bool), Order = 0)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 2)]
		public Business_Process_Comment_DataType Business_Process_Comment_Data
		{
			get
			{
				return this.business_Process_Comment_DataField;
			}
			set
			{
				this.business_Process_Comment_DataField = value;
				this.RaisePropertyChanged("Business_Process_Comment_Data");
			}
		}

		[XmlElement("Business_Process_Attachment_Data", Order = 3)]
		public Business_Process_Attachment_DataType[] Business_Process_Attachment_Data
		{
			get
			{
				return this.business_Process_Attachment_DataField;
			}
			set
			{
				this.business_Process_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Process_Attachment_Data");
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
