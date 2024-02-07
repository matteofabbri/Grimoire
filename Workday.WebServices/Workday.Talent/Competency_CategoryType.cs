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
	public class Competency_CategoryType : INotifyPropertyChanged
	{
		private Competency_CategoryObjectType competency_Category_ReferenceField;

		private Competency_Category_DataType[] competency_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Competency_CategoryObjectType Competency_Category_Reference
		{
			get
			{
				return this.competency_Category_ReferenceField;
			}
			set
			{
				this.competency_Category_ReferenceField = value;
				this.RaisePropertyChanged("Competency_Category_Reference");
			}
		}

		[XmlElement("Competency_Category_Data", Order = 1)]
		public Competency_Category_DataType[] Competency_Category_Data
		{
			get
			{
				return this.competency_Category_DataField;
			}
			set
			{
				this.competency_Category_DataField = value;
				this.RaisePropertyChanged("Competency_Category_Data");
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
