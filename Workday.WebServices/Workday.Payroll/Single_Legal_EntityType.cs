using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Single_Legal_EntityType : INotifyPropertyChanged
	{
		private Single_Legal_EntityObjectType single_Legal_Entity_ReferenceField;

		private Single_Legal_Entity_DataType single_Legal_Entity_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Single_Legal_EntityObjectType Single_Legal_Entity_Reference
		{
			get
			{
				return this.single_Legal_Entity_ReferenceField;
			}
			set
			{
				this.single_Legal_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Single_Legal_Entity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Single_Legal_Entity_DataType Single_Legal_Entity_Data
		{
			get
			{
				return this.single_Legal_Entity_DataField;
			}
			set
			{
				this.single_Legal_Entity_DataField = value;
				this.RaisePropertyChanged("Single_Legal_Entity_Data");
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
