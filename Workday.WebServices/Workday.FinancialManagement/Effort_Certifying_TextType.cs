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
	public class Effort_Certifying_TextType : INotifyPropertyChanged
	{
		private Effort_Certifying_TextObjectType effort_Certifying_Text_ReferenceField;

		private Effort_Certifying_Text_DataType[] effort_Certifying_Text_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Effort_Certifying_TextObjectType Effort_Certifying_Text_Reference
		{
			get
			{
				return this.effort_Certifying_Text_ReferenceField;
			}
			set
			{
				this.effort_Certifying_Text_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_Reference");
			}
		}

		[XmlElement("Effort_Certifying_Text_Data", Order = 1)]
		public Effort_Certifying_Text_DataType[] Effort_Certifying_Text_Data
		{
			get
			{
				return this.effort_Certifying_Text_DataField;
			}
			set
			{
				this.effort_Certifying_Text_DataField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_Data");
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
