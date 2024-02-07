using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_Statement_TypeType : INotifyPropertyChanged
	{
		private Talent_Statement_TypeObjectType talent_Statement_Type_ReferenceField;

		private Talent_Statement_Type_DataType[] talent_Statement_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Talent_Statement_TypeObjectType Talent_Statement_Type_Reference
		{
			get
			{
				return this.talent_Statement_Type_ReferenceField;
			}
			set
			{
				this.talent_Statement_Type_ReferenceField = value;
				this.RaisePropertyChanged("Talent_Statement_Type_Reference");
			}
		}

		[XmlElement("Talent_Statement_Type_Data", Order = 1)]
		public Talent_Statement_Type_DataType[] Talent_Statement_Type_Data
		{
			get
			{
				return this.talent_Statement_Type_DataField;
			}
			set
			{
				this.talent_Statement_Type_DataField = value;
				this.RaisePropertyChanged("Talent_Statement_Type_Data");
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
