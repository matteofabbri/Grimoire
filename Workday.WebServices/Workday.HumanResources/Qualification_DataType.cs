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
	public class Qualification_DataType : INotifyPropertyChanged
	{
		private Education_History_DataType[] education_DataField;

		private Professional_Experience_DataType[] professional_Experience_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Education_Data", Order = 0)]
		public Education_History_DataType[] Education_Data
		{
			get
			{
				return this.education_DataField;
			}
			set
			{
				this.education_DataField = value;
				this.RaisePropertyChanged("Education_Data");
			}
		}

		[XmlElement("Professional_Experience_Data", Order = 1)]
		public Professional_Experience_DataType[] Professional_Experience_Data
		{
			get
			{
				return this.professional_Experience_DataField;
			}
			set
			{
				this.professional_Experience_DataField = value;
				this.RaisePropertyChanged("Professional_Experience_Data");
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
