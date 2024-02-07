using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Internal_Project_ExperienceType : INotifyPropertyChanged
	{
		private Internal_Project_ExperienceObjectType internal_Project_Experience_ReferenceField;

		private Internal_Project_Experience_DataType[] internal_Project_Experience_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Internal_Project_ExperienceObjectType Internal_Project_Experience_Reference
		{
			get
			{
				return this.internal_Project_Experience_ReferenceField;
			}
			set
			{
				this.internal_Project_Experience_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Project_Experience_Reference");
			}
		}

		[XmlElement("Internal_Project_Experience_Data", Order = 1)]
		public Internal_Project_Experience_DataType[] Internal_Project_Experience_Data
		{
			get
			{
				return this.internal_Project_Experience_DataField;
			}
			set
			{
				this.internal_Project_Experience_DataField = value;
				this.RaisePropertyChanged("Internal_Project_Experience_Data");
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
