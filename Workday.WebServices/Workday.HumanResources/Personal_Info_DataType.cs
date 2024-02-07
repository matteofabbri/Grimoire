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
	public class Personal_Info_DataType : INotifyPropertyChanged
	{
		private string business_TitleField;

		private Person_DataType person_DataField;

		private Qualification_DataType qualification_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Business_Title
		{
			get
			{
				return this.business_TitleField;
			}
			set
			{
				this.business_TitleField = value;
				this.RaisePropertyChanged("Business_Title");
			}
		}

		[XmlElement(Order = 1)]
		public Person_DataType Person_Data
		{
			get
			{
				return this.person_DataField;
			}
			set
			{
				this.person_DataField = value;
				this.RaisePropertyChanged("Person_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Qualification_DataType Qualification_Data
		{
			get
			{
				return this.qualification_DataField;
			}
			set
			{
				this.qualification_DataField = value;
				this.RaisePropertyChanged("Qualification_Data");
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
