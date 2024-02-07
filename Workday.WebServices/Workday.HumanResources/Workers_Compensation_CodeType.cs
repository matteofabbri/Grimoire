using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workers_Compensation_CodeType : INotifyPropertyChanged
	{
		private Workers_Compensation_CodeObjectType workers_Compensation_Code_ReferenceField;

		private Workers_Compensation_Code_DataType workers_Compensation_Code_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Workers_Compensation_CodeObjectType Workers_Compensation_Code_Reference
		{
			get
			{
				return this.workers_Compensation_Code_ReferenceField;
			}
			set
			{
				this.workers_Compensation_Code_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Workers_Compensation_Code_DataType Workers_Compensation_Code_Data
		{
			get
			{
				return this.workers_Compensation_Code_DataField;
			}
			set
			{
				this.workers_Compensation_Code_DataField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code_Data");
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
