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
	public class Worker_Personal_Info_DataType : INotifyPropertyChanged
	{
		private IDType[] external_Integration_ID_DataField;

		private Personal_Info_DataType personal_Info_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("ID", IsNullable = false)]
		public IDType[] External_Integration_ID_Data
		{
			get
			{
				return this.external_Integration_ID_DataField;
			}
			set
			{
				this.external_Integration_ID_DataField = value;
				this.RaisePropertyChanged("External_Integration_ID_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Personal_Info_DataType Personal_Info_Data
		{
			get
			{
				return this.personal_Info_DataField;
			}
			set
			{
				this.personal_Info_DataField = value;
				this.RaisePropertyChanged("Personal_Info_Data");
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
