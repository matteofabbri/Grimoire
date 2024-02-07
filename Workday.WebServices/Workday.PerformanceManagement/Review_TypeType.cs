using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Review_TypeType : INotifyPropertyChanged
	{
		private Review_TypeObjectType review_Type_ReferenceField;

		private Review_Type_DataType[] review_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Review_TypeObjectType Review_Type_Reference
		{
			get
			{
				return this.review_Type_ReferenceField;
			}
			set
			{
				this.review_Type_ReferenceField = value;
				this.RaisePropertyChanged("Review_Type_Reference");
			}
		}

		[XmlElement("Review_Type_Data", Order = 1)]
		public Review_Type_DataType[] Review_Type_Data
		{
			get
			{
				return this.review_Type_DataField;
			}
			set
			{
				this.review_Type_DataField = value;
				this.RaisePropertyChanged("Review_Type_Data");
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
