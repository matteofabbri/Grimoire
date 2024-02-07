using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class PublicationType : INotifyPropertyChanged
	{
		private Publication_SkillObjectType publication_ReferenceField;

		private Publication_Achievement_DataType publication_Achievement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Publication_SkillObjectType Publication_Reference
		{
			get
			{
				return this.publication_ReferenceField;
			}
			set
			{
				this.publication_ReferenceField = value;
				this.RaisePropertyChanged("Publication_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Publication_Achievement_DataType Publication_Achievement_Data
		{
			get
			{
				return this.publication_Achievement_DataField;
			}
			set
			{
				this.publication_Achievement_DataField = value;
				this.RaisePropertyChanged("Publication_Achievement_Data");
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
