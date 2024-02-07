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
	public class Difficulty_to_FillType : INotifyPropertyChanged
	{
		private Difficulty_to_FillObjectType difficulty_to_Fill_ReferenceField;

		private Difficulty_to_Fill_DataType difficulty_to_Fill_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Difficulty_to_FillObjectType Difficulty_to_Fill_Reference
		{
			get
			{
				return this.difficulty_to_Fill_ReferenceField;
			}
			set
			{
				this.difficulty_to_Fill_ReferenceField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Difficulty_to_Fill_DataType Difficulty_to_Fill_Data
		{
			get
			{
				return this.difficulty_to_Fill_DataField;
			}
			set
			{
				this.difficulty_to_Fill_DataField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Data");
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
