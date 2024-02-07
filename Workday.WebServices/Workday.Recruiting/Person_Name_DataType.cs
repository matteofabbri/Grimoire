using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Name_DataType : INotifyPropertyChanged
	{
		private Legal_Name_DataType legal_Name_DataField;

		private Preferred_Name_DataType preferred_Name_DataField;

		private Additional_Name_DataType[] additional_Name_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Legal_Name_DataType Legal_Name_Data
		{
			get
			{
				return this.legal_Name_DataField;
			}
			set
			{
				this.legal_Name_DataField = value;
				this.RaisePropertyChanged("Legal_Name_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Preferred_Name_DataType Preferred_Name_Data
		{
			get
			{
				return this.preferred_Name_DataField;
			}
			set
			{
				this.preferred_Name_DataField = value;
				this.RaisePropertyChanged("Preferred_Name_Data");
			}
		}

		[XmlElement("Additional_Name_Data", Order = 2)]
		public Additional_Name_DataType[] Additional_Name_Data
		{
			get
			{
				return this.additional_Name_DataField;
			}
			set
			{
				this.additional_Name_DataField = value;
				this.RaisePropertyChanged("Additional_Name_Data");
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
