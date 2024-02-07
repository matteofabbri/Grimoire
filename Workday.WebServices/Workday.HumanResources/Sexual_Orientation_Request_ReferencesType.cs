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
	public class Sexual_Orientation_Request_ReferencesType : INotifyPropertyChanged
	{
		private Sexual_OrientationObjectType[] sexual_Orientation_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Sexual_Orientation_Reference", Order = 0)]
		public Sexual_OrientationObjectType[] Sexual_Orientation_Reference
		{
			get
			{
				return this.sexual_Orientation_ReferenceField;
			}
			set
			{
				this.sexual_Orientation_ReferenceField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Reference");
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
