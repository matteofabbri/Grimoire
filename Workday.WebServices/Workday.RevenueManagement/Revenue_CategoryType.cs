using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Revenue_CategoryType : INotifyPropertyChanged
	{
		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private Revenue_Category_DataType revenue_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Revenue_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Revenue_Category_DataType Revenue_Category_Data
		{
			get
			{
				return this.revenue_Category_DataField;
			}
			set
			{
				this.revenue_Category_DataField = value;
				this.RaisePropertyChanged("Revenue_Category_Data");
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
