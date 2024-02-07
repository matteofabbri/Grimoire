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
	public class Insurance_Coverage_Level_DataType : INotifyPropertyChanged
	{
		private Coverage_Level_Value_DataType coverage_Level_Value_DataField;

		private Volume_DataType volume_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Coverage_Level_Value_DataType Coverage_Level_Value_Data
		{
			get
			{
				return this.coverage_Level_Value_DataField;
			}
			set
			{
				this.coverage_Level_Value_DataField = value;
				this.RaisePropertyChanged("Coverage_Level_Value_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Volume_DataType Volume_Data
		{
			get
			{
				return this.volume_DataField;
			}
			set
			{
				this.volume_DataField = value;
				this.RaisePropertyChanged("Volume_Data");
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
