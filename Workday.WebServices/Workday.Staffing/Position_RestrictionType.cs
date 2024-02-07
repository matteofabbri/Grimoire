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
	public class Position_RestrictionType : INotifyPropertyChanged
	{
		private Position_RestrictionsObjectType position_ReferenceField;

		private Position_DataType position_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_RestrictionsObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Position_DataType Position_Data
		{
			get
			{
				return this.position_DataField;
			}
			set
			{
				this.position_DataField = value;
				this.RaisePropertyChanged("Position_Data");
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
