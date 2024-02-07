using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Custom_Report_Transformation_DataType : INotifyPropertyChanged
	{
		private Custom_Report_TransformationObjectType custom_Report_Transformation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Custom_Report_TransformationObjectType Custom_Report_Transformation_Reference
		{
			get
			{
				return this.custom_Report_Transformation_ReferenceField;
			}
			set
			{
				this.custom_Report_Transformation_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Report_Transformation_Reference");
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
