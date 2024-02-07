using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Communication_Usage_Type_Order_DataType : INotifyPropertyChanged
	{
		private string engagement_Communication_Usage_Type_Order_ValueField;

		private Communication_Usage_TypeObjectType communication_Usage_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Engagement_Communication_Usage_Type_Order_Value
		{
			get
			{
				return this.engagement_Communication_Usage_Type_Order_ValueField;
			}
			set
			{
				this.engagement_Communication_Usage_Type_Order_ValueField = value;
				this.RaisePropertyChanged("Engagement_Communication_Usage_Type_Order_Value");
			}
		}

		[XmlElement(Order = 1)]
		public Communication_Usage_TypeObjectType Communication_Usage_Type_Reference
		{
			get
			{
				return this.communication_Usage_Type_ReferenceField;
			}
			set
			{
				this.communication_Usage_Type_ReferenceField = value;
				this.RaisePropertyChanged("Communication_Usage_Type_Reference");
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
