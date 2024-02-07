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
	public class Difficulty_to_Fill_Request_ReferencesType : INotifyPropertyChanged
	{
		private Difficulty_to_FillObjectType[] difficulty_to_Fill_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Difficulty_to_Fill_Reference", Order = 0)]
		public Difficulty_to_FillObjectType[] Difficulty_to_Fill_Reference
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
