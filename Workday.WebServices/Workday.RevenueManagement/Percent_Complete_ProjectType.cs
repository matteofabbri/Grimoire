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
	public class Percent_Complete_ProjectType : INotifyPropertyChanged
	{
		private Percent_Complete_ProjectObjectType percent_Complete_Project_ReferenceField;

		private Percent_Complete_Project_DataType[] percent_Complete_Project_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Percent_Complete_ProjectObjectType Percent_Complete_Project_Reference
		{
			get
			{
				return this.percent_Complete_Project_ReferenceField;
			}
			set
			{
				this.percent_Complete_Project_ReferenceField = value;
				this.RaisePropertyChanged("Percent_Complete_Project_Reference");
			}
		}

		[XmlElement("Percent_Complete_Project_Data", Order = 1)]
		public Percent_Complete_Project_DataType[] Percent_Complete_Project_Data
		{
			get
			{
				return this.percent_Complete_Project_DataField;
			}
			set
			{
				this.percent_Complete_Project_DataField = value;
				this.RaisePropertyChanged("Percent_Complete_Project_Data");
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
