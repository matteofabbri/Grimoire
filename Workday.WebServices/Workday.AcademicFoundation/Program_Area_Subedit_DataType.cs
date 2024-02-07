using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Program_Area_Subedit_DataType : INotifyPropertyChanged
	{
		private Program_AreaObjectType program_Area_ReferenceField;

		private Program_Area_TypeObjectType program_Area_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Program_AreaObjectType Program_Area_Reference
		{
			get
			{
				return this.program_Area_ReferenceField;
			}
			set
			{
				this.program_Area_ReferenceField = value;
				this.RaisePropertyChanged("Program_Area_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Program_Area_TypeObjectType Program_Area_Type_Reference
		{
			get
			{
				return this.program_Area_Type_ReferenceField;
			}
			set
			{
				this.program_Area_Type_ReferenceField = value;
				this.RaisePropertyChanged("Program_Area_Type_Reference");
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
