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
	public class Purchase_Order_Acknowledgement_OutboundType : INotifyPropertyChanged
	{
		private Purchase_Order_AcknowledgementObjectType purchase_Order_Acknowledgement_ReferenceField;

		private Purchase_Order_Acknowledgement_DataType[] purchase_Order_Acknowledgement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_AcknowledgementObjectType Purchase_Order_Acknowledgement_Reference
		{
			get
			{
				return this.purchase_Order_Acknowledgement_ReferenceField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Reference");
			}
		}

		[XmlElement("Purchase_Order_Acknowledgement_Data", Order = 1)]
		public Purchase_Order_Acknowledgement_DataType[] Purchase_Order_Acknowledgement_Data
		{
			get
			{
				return this.purchase_Order_Acknowledgement_DataField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_DataField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Data");
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
